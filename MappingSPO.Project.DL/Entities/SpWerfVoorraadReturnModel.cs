
namespace MappingSPO.Project.DL.Entities
{
    public class SpWerfVoorraadReturnModel
    {
        public System.Int64? SBLeveringDetailID { get; set; }
        public System.Int64? DetailID { get; set; }
        public System.Int32 WerfState { get; set; }
        public System.String FullWerfNumber { get; set; }
        public System.String WerfName { get; set; }
        public System.Int32? DefailtCompanyID { get; set; }
        public System.String DefaultCompany { get; set; }
        public System.String WerfLeider { get; set; }
        public System.String WerfLeiderGSM { get; set; }
        public System.String ProjectLeider { get; set; }
        public System.String ProjectLeiderGSM { get; set; }
        public System.String ProjectNaam { get; set; }
        public System.String ProjectNumber { get; set; }
        public System.String WerfAdres { get; set; }
        public System.String WerfAdresName { get; set; }
        public System.DateTime? StartDate { get; set; }
        public System.DateTime? EndDate { get; set; }
        public System.DateTime? VoorlopigeOpleveringsdatum { get; set; }
        public System.DateTime? DefinitieveOpleveringsdatum { get; set; }
        public System.Int64 WerfID { get; set; }
        public System.String BestelCode { get; set; }
        public System.Double? TotaalGeleverd { get; set; }
        public System.Double? TotaalKost { get; set; }
        public System.Double? TotaalGeleverdVoorDatum { get; set; }
        public System.Double? TotaalKostVoorDatum { get; set; }
        public System.Double? VoorraadAantal { get; set; }
        public System.String Code1SB { get; set; }
        public System.String Code2SB { get; set; }
        public System.String Code3SB { get; set; }
        public System.String Code4SB { get; set; }
        public System.String Code5SB { get; set; }
        public System.String Code6SB { get; set; }
        public System.String Code7SB { get; set; }
        public System.String Code8SB { get; set; }
        public System.String FullCodeSB { get; set; }
        public System.String Description { get; set; }
        public System.String KS { get; set; }
        public System.String UC { get; set; }
        public System.String Code1WL { get; set; }
        public System.String Code2WL { get; set; }
        public System.String Code3WL { get; set; }
        public System.String Code4WL { get; set; }
        public System.String Code5WL { get; set; }
        public System.String Code6WL { get; set; }
        public System.String Code7WL { get; set; }
        public System.String Code8WL { get; set; }
        public System.String FullCodeWL { get; set; }
        public System.Double? BEKP { get; set; }
        public System.Int64? Voorraad { get; set; }
        public System.DateTime? KostDatum { get; set; }
        public System.Int32? HasWerflijstLink { get; set; }
    }
}
