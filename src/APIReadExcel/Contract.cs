using System.ComponentModel;
using SpreadSheetParser.Models;

namespace APIReadExcel
{
    [DisplayName("Contratos Cedidos")]
    public class SheetContract : SheetObject
    {
        [DisplayName("Número Contrato")]
        public string ClientName { get; set; }

        [DisplayName("Número CPF/CNPJ")]
        public string DocumentNumber { get; set; }

        [DisplayName("Nome do Investidor")]
        public string InvestorName { get; set; }

        public SheetContract(SheetHeader header, SheetRow row) : base(header, row)
        {
            if (TryBuildObject<SheetContract>(this) is false)
                throw new ArgumentException("Could not create a sample object");
        }
    }
}