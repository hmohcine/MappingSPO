using MappingSPO.Framework.BL.Common;
using MappingSPO.Framework.BL.Contracts.Project;
using MappingSPO.Framework.BL.Services.Project;
using MappingSPO.Project.DL;
using System;
using System.Linq;
using AutoMapper;
using System.Windows.Forms;

namespace MappingSPO
{
    public partial class Form1 : Form
    {
        private XrmContext myXrmContext = new XrmContext();
        private ProjectContext myProjectContext = new ProjectContext();


        private readonly IProjectService _projectService;
        private readonly ISiteService _siteService;

        //public Form1()
        //{
        //    InitializeComponent();
        //}

        public Form1(IServiceFactory serviceFactory)
        {
            InitializeComponent();
            _projectService = serviceFactory.GetService<IProjectService>();
            _siteService = serviceFactory.GetService<ISiteService>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var ProjectList = myProjectContext.Projects.ToList();

            var ProjectList = _projectService.GetAllProjects();

            listBoxControl1.Items.Clear();
            foreach (var item in ProjectList)
            {
                listBoxControl1.Items.Add(item.ProjectName + "#" + item.ProjectNumber);
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBoxControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var t = listBoxControl1.SelectedItem;
            listBoxControl4.Items.Clear();
            if (t != null)
            {
                var projectId = Convert.ToInt32(t.ToString().Split('#')[1]);


                var project = myProjectContext.Projects.FirstOrDefault(x => x.ProjectId == projectId);

                // get Resp Project

                if (project.ProjectVerantWoordelijke1.HasValue)
                {
                    var employee = myXrmContext.Employees.FirstOrDefault(x => x.EmployeeId == project.ProjectVerantWoordelijke1);
                    if (employee != null)
                        listBoxControl4.Items.Add("ProjectVerantWoordelijke1  : " + employee.FirstName + " " + employee.LastName + "#" + employee.Email);
                }
                if (project.ProjectVerantWoordelijke2.HasValue)
                {
                    var employee = myXrmContext.Employees.FirstOrDefault(x => x.EmployeeId == project.ProjectVerantWoordelijke2);
                    if (employee != null)
                        listBoxControl4.Items.Add("ProjectVerantWoordelijke2  : " + employee.FirstName + " " + employee.LastName + "#" + employee.Email);
                }
                if (project.ProjectVerantWoordelijke3.HasValue)
                {
                    var employee = myXrmContext.Employees.FirstOrDefault(x => x.EmployeeId == project.ProjectVerantWoordelijke3);
                    if (employee != null)
                        listBoxControl4.Items.Add("ProjectVerantWoordelijke3  : " + employee.FirstName + " " + employee.LastName + "#" + employee.Email);
                }

                // get Sites linked wwith Project
                var ListSite = myProjectContext.ProjectWerfs.Where(x => x.ProjectId == projectId).Select(f => f.Werf).ToList();
                listBoxControl2.Items.Clear();
                foreach (var item in ListSite)
                {
                    listBoxControl2.Items.Add(item.WerfName + "#" + item.WerfId);
                }

                // get Calculation linked wwith Project
                var ListCalculation = myProjectContext.Projects.FirstOrDefault(x => x.ProjectId == projectId).ProjectCalculations.ToList();
                listBoxControl3.Items.Clear();
                foreach (var item in ListCalculation)
                {
                    listBoxControl3.Items.Add(item.Calculation.CalcNumber + "#" + item.CalcId);
                }

                // get Relations linked wwith Project
                var ListRelation = myProjectContext.Projects.FirstOrDefault(x => x.ProjectId == projectId).ProjectRelations.ToList();
                listBoxControl5.Items.Clear();
                foreach (var item in ListRelation)
                {
                    listBoxControl5.Items.Add(item.Relation.Name + "#" + item.RelationId);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var ListCalculation = myProjectContext.Calculations.Where(x => x.Domain.ToLower().Contains("c")).ToList();
            listBoxControl3.Items.Clear();
            foreach (var item in ListCalculation)
            {
                listBoxControl3.Items.Add(item.CalcName + "#" + item.CalcId);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var ListSites = _siteService.GetAllSites();
            listBoxControl2.Items.Clear();
            foreach (var item in ListSites)
            {
                listBoxControl2.Items.Add(item.WerfName + "#" + item.WerfId + "#" +
                                           item.ProjectName + "#" + item.VerantWoordelijke1 + "#" + item.VerantWoordelijke2 + "#" + item.WerfNumber);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var ListRelation = myXrmContext.Relations.ToList();
            listBoxControl5.Items.Clear();
            foreach (var item in ListRelation)
            {
                listBoxControl5.Items.Add(item.Name + "#" + item.RelationId);
            }
        }

        private void listBoxControl5_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxControl6.Items.Clear();
            if (listBoxControl5.SelectedItem != null)
            {
                var relationId = Convert.ToInt32(listBoxControl5.SelectedItem.ToString().Split('#')[1]);
                var ListContacts = myXrmContext.RelationsContacts.Where(x => x.RelationId == relationId).ToList();

                foreach (var item in ListContacts)
                {
                    var contact = myXrmContext.Contacts.FirstOrDefault(x => x.ContactId == item.ContactId);
                    listBoxControl6.Items.Add(contact.Name + "#" + item.Email);
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void listBoxControl6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxControl7.Items.Clear();
            if (listBoxControl2.SelectedItem != null)
            {
                var SiteId = Convert.ToInt32(listBoxControl2.SelectedItem.ToString().Split('#')[1]);   
                if (SiteId != 0)
                {
                    var site = myProjectContext.ProjectWerfs.Where(x => x.WerfId == SiteId).Select(f => f.Werf).FirstOrDefault();
                    if (site != null)
                    {
                        // get Resp Site
                        if (site.Werfleider.HasValue)
                        {
                            var employee = myXrmContext.Employees.FirstOrDefault(x => x.EmployeeId == site.Werfleider);
                            if (employee != null)
                                listBoxControl7.Items.Add("Werfleider  : " + employee.FirstName + " " + employee.LastName + "#" + employee.Email);
                        }
                        if (site.ProjectLeider.HasValue)
                        {
                            var employee = myXrmContext.Employees.FirstOrDefault(x => x.EmployeeId == site.ProjectLeider);
                            if (employee != null)
                                listBoxControl7.Items.Add("ProjectLeider  : " + employee.FirstName + " " + employee.LastName + "#" + employee.Email);
                        }
                    }
                }
            }
        }

        private void listBoxControl3_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxControl8.Items.Clear();
            if (listBoxControl3.SelectedItem != null)
            {
                var CalculationId = Convert.ToInt32(listBoxControl3.SelectedItem.ToString().Split('#')[1]);
                if (CalculationId != null)
                {
                    var calculation = myProjectContext.Calculations.FirstOrDefault(f => f.CalcId == CalculationId);

                    if (calculation != null)
                    {
                        if (calculation.Calculator.HasValue)
                        {
                            var employee = myXrmContext.Employees.FirstOrDefault(x => x.EmployeeId == calculation.Calculator);
                            if (employee != null)
                                listBoxControl8.Items.Add(employee.FirstName + " " + employee.LastName + "#" + employee.Email);
                        }
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var ListDocuments = myXrmContext.Documents.ToList();
            listBoxControl10.Items.Clear();
            foreach (var item in ListDocuments)
            {
                listBoxControl10.Items.Add(item.Name + "#" + item.DocumentId);
            }
        }

        private void listBoxControl10_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxControl1.Items.Clear();
            if (listBoxControl10.SelectedItem != null)
            {
                var docId = Convert.ToInt32(listBoxControl10.SelectedItem.ToString().Split('#')[1]);
                if (docId != 0)
                {
                    var document = myXrmContext.Documents.FirstOrDefault(x => x.DocumentId == docId);

                    if (document != null)
                    {
                        lblDocType.Text = document.ExtentionId;
                        lblPath.Text = "//" + document.SubPath + "/" + document.FullAlias;
                    }
                }

                // GetProject linked with document
                var ProjectList = myProjectContext.ProjectDocuments.Where(x => x.DocumentId == docId).Select(f => f.Project).ToList();


                foreach (var item in ProjectList)
                {
                    listBoxControl1.Items.Add(item.ProjectName + "#" + item.ProjectId);
                }
            }
        }
    }
}
