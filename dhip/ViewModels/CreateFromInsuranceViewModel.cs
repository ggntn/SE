using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dhip.ViewModels
{
    public class CreateFromInsuranceViewModel
    {
        public DateTime date { get; set; }
        public DateTime incidentDate { get; set; }
        public DateTime timeIncidentDate { get; set; }
        public string nameClaim { get; set; }
        public string phoneClaim { get; set; }
        public string emailClaim { get; set; }
        public string nameContact { get; set; }
        public string phoneContact { get; set; }
        public string emailContact { get; set; }
        public string insuranceNo { get; set; }
        public string place { get; set; }
        public string soi { get; set; }
        public string road { get; set; }
        public string province { get; set; }

        public int typeHouse { get; set; }
        public int floor { get; set; }
        public int wall { get; set; }
        public int ceiling { get; set; }
        public int roof { get; set; }
        public int glass { get; set; }
        public int etc { get; set; }

        public int meterialFloorSelect { get; set; }
        public string piecesFloor { get; set; }
        public int unitFloor { get; set; }

        public int meterialWallSelect { get; set; }
        public string piecesWall { get; set; }
        public int unitWall { get; set; }

        public int meterialCeilingSelect { get; set; }
        public string piecesCeiling { get; set; }
        public int unitCeiling { get; set; }

        public int meterialRoofSelect { get; set; }
        public string piecesRoof { get; set; }
        public int unitRoof { get; set; }

        public int meterialGlassSelect { get; set; }
        public string piecesGlass { get; set; }
        public int unitGlass { get; set; }

        public string meterialEtcSelect { get; set; }
        public string piecesEtc { get; set; }
        public int unitEtc { get; set; }

        public int incidentPrice { get; set; }
        public int causeIncident { get; set; }
        public string causeIncidentDetail { get; set; }


        public int formId { get; set; }


        //public IFormFile photo { get; set; }
        //public byte[] dataImg { get; set; }
    }
}
