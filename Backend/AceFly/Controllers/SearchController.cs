using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AceFly.Models;

namespace AceFly.Controllers
{
    public class SearchController : ApiController
    {
        FlyAceEntities db = new FlyAceEntities();
        [HttpGet]
        public IHttpActionResult searchFlight(string from, string to, DateTime trvDate)
        {
            return Ok(db.prc_getFlights(from, to, trvDate).ToList());
        }
        [HttpGet]
        public IHttpActionResult getSeats(string scheduleId)
        {
            var result = db.prc_getSeats(scheduleId).ToList();
            //Seat[] seats = new Seat[4];
            //seats[0] = null;
            //List<Seat[]> rowSeat = new List<Seat[]>();
            string[] seatNos = new string[result.Count];
            int k = 0;
            foreach(var s in result)
            {
                seatNos[k] = s.seatNo;
                k++;
            }
            Seat[,] rowSeats = new Seat[result.Count / 4, 4];
            int row = 0;
            for(int i=0; i< result.Count / 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Seat s = new Seat();
                    s.row = seatNos[row].Substring(0, seatNos[row].Length - 1); 
                    s.letter = seatNos[row].Substring(seatNos[row].Length - 1);
                    s.isAvailable = result[row].isAvailable;
                    s.seatClass = result[row].seatClass;
                    s.check = false;
                    rowSeats[i, j] = s;
                    row++;
                }
            }
            //foreach (var s in result)
            //    {
            //        seats[i].row = s.seatNo.Substring(s.seatNo.Length - 1);
            //        seats[i].letter = s.seatNo.Substring(0, s.seatNo.Length - 1);
            //        seats[i].isAvailable = s.isAvailable;
            //        seats[i].seatClass = s.seatClass;
            //        seats[i].check = false;
            //        i++;
            //        if(i>=3)
            //        {
            //            rowSeat.Add(seats);
            //            i = 0;
            //        }
            //    }

            return Ok(rowSeats);
        }
    }
}
