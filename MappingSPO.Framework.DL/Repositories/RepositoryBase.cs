using MappingSPO.Framework.DL.Contracts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;

namespace MappingSPO.Framework.DL.Repository
{
    public abstract class RepositoryBase<TEntity, TDbContext> : IRepositoryBase<TEntity>
      where TEntity : class, new()
      where TDbContext : DbContext, new()
    {
        //protected abstract TEntity AddEntity(TDbContext entityContext, TEntity entity);

        //protected abstract TEntity UpdateEntity(TDbContext entityContext, TEntity entity);

        protected abstract TEntity GetEntity(TDbContext entityContext, object id);

        protected abstract IEnumerable<TEntity> GetEntities(TDbContext entityContext);

        protected abstract IEnumerable<TEntity> GetEntities(TDbContext entityContext, Expression<Func<TEntity, bool>> filter);

        //public void Remove(TEntity entity)
        //{
        //    using (TDbContext entityContext = new TDbContext())
        //    {
        //        entityContext.Entry<TEntity>(entity).State = EntityState.Deleted;
        //        entityContext.SaveChanges();
        //    }
        //}

        //public void Remove(object id)
        //{
        //    using (TDbContext entityContext = new TDbContext())
        //    {
        //        TEntity entity = GetEntity(entityContext, id);
        //        entityContext.Entry<TEntity>(entity).State = EntityState.Deleted;
        //        entityContext.SaveChanges();
        //    }
        //}
        public bool IsRecordInUse(object id)
        {
            if (id is sbyte
            || id is byte
            || id is short
            || id is ushort
            || id is int
            || id is uint
            || id is long
            || id is ulong)
            {
                return IsRecordInUseBigint(Convert.ToInt64(id));
            }

            if (id is string)
            {
                return IsRecordInUseString((string) id);
            }
           
            throw new System.NotImplementedException("Only int, long and string allowed for the PK");
        }

        public bool IsRecordInUseBigint(long id)
        {
            string PKschemaName;
            string PKtableName;
            using (TDbContext entityContext = new TDbContext())
            {
                var entitySet = GetEntitySet<TEntity>(entityContext);
                if (entitySet == null)
                    throw new System.Exception("Unable to find entity set in edm metadata");
                PKschemaName = GetStringProperty(entitySet, "Schema");
                PKtableName = GetStringProperty(entitySet, "Table");

                var result = entityContext.Database.SqlQuery<bool>("spCalcInUseBigintPK @TableName, @SchemaName, @BigintPKValue",
                    new SqlParameter("@TableName", PKtableName),
                    new SqlParameter("@SchemaName", PKschemaName),
                    new SqlParameter("@BigintPKValue", id)).FirstOrDefault();
                return result;
            }
        }

        public bool IsRecordInUseString(string id)
        {
            string PKschemaName;
            string PKtableName;
            using (TDbContext entityContext = new TDbContext())
            {
                var entitySet = GetEntitySet<TEntity>(entityContext);
                if (entitySet == null)
                    throw new System.Exception("Unable to find entity set in edm metadata");
                PKschemaName = GetStringProperty(entitySet, "Schema");
                PKtableName = GetStringProperty(entitySet, "Table");

                var result = entityContext.Database.SqlQuery<bool>("spCalcInUseStringPK @TableName, @SchemaName, @StringValue",
                    new SqlParameter("@TableName", PKtableName),
                    new SqlParameter("@SchemaName", PKschemaName),
                    new SqlParameter("@StringValue", id)).FirstOrDefault();
                return result;
            }
        }
        
        private string GetStringProperty(MetadataItem entitySet, string propertyName)
        {
            MetadataProperty property;
            if (entitySet == null)
                throw new System.ArgumentNullException("entitySet");
            if (entitySet.MetadataProperties.TryGetValue(propertyName, false, out property))
            {
                string str = null;
                if (((property != null) &&
                    (property.Value != null)) &&
                    (((str = property.Value as string) != null) &&
                    !string.IsNullOrEmpty(str)))
                {
                    return str;
                }
            }
            return string.Empty;
        }
        private EntitySet GetEntitySet<T>(DbContext context)
        {
            var type = typeof(T);
            var entityName = type.Name;
            var metadata = ((IObjectContextAdapter)context).ObjectContext.MetadataWorkspace;

            IEnumerable<EntitySet> entitySets;
            entitySets = metadata.GetItemCollection(DataSpace.SSpace)
                             .GetItems<EntityContainer>()
                             .Single()
                             .BaseEntitySets
                             .OfType<EntitySet>()
                             .Where(s => !s.MetadataProperties.Contains("Type")
                                         || s.MetadataProperties["Type"].ToString() == "Tables");
            var entitySet = entitySets.FirstOrDefault(t => t.Name == entityName);
            return entitySet;
        }

        //public TEntity Add(TEntity entity)
        //{
        //    using (TDbContext entityContext = new TDbContext())
        //    {
        //        entityContext.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);

        //        TEntity addedEntity = AddEntity(entityContext, entity);
        //        entityContext.SaveChanges();
        //        return addedEntity;
        //    }
        //}

        //public TEntity Update(TEntity entity)
        //{
        //    using (TDbContext entityContext = new TDbContext())
        //    {
        //        entityContext.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);

        //        TEntity existingEntity = UpdateEntity(entityContext, entity);

        //        entityContext.Entry(existingEntity).CurrentValues.SetValues(entity);

        //        entityContext.SaveChanges();
        //        return existingEntity;
        //    }
        //}

        //public IEnumerable<TEntity> Update(IEnumerable<TEntity> entities)
        //{
        //    using (TDbContext entityContext = new TDbContext())
        //    {
        //        List<TEntity> existingEntities = new List<TEntity>();

        //        foreach (TEntity entity in entities)
        //        {
        //            TEntity existingEntity = UpdateEntity(entityContext, entity);

        //            entityContext.Entry(existingEntity).CurrentValues.SetValues(entity);

        //            existingEntities.Add(existingEntity);
        //        }
        //        entityContext.SaveChanges();

        //        return existingEntities;
        //    }
        //}

        public TEntity Get(object id)
        {
            using (TDbContext entityContext = new TDbContext())
                return GetEntity(entityContext, id);
        }

        public IEnumerable<TEntity> Get()
        {
            using (TDbContext entityContext = new TDbContext())
                return (GetEntities(entityContext)).ToArray().ToList();
        }

        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TDbContext entityContext = new TDbContext())
                return (GetEntities(entityContext, filter)).ToArray().ToList();
        }

        private static bool bulkExtensionsInitialised = false;
        protected static void InitializeBulkExtensions()
        {
            if (bulkExtensionsInitialised) return;

            // https://entityframework-extensions.net/licensing
            // Z.EntityFramework.Extensions.LicenseManager.AddLicense([licenseName], [licenseKey]);
            
            Z.EntityFramework.Extensions.LicenseManager.AddLicense("4100;101-build-software.eu", "10e492f2-8512-7f29-e275-60d4bf3f0311");
            bulkExtensionsInitialised = true;

            /*
            // CHECK if the license is valid for the default provider (SQL Server)
            string licenseErrorMessage;
            if (!Z.EntityFramework.Extensions.LicenseManager.ValidateLicense(out licenseErrorMessage))
            {
                throw new Exception(licenseErrorMessage);
            }
            */
        }
    }
}
