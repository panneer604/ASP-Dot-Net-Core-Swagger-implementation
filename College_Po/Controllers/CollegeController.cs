using College_Po.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace College_Po.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CollegeController : ControllerBase
    {
        private List<College> Collegeouss = new List<College>() {

              new College(){

                Id = 1,
                Name = "Yasar Arafath",
                Place = "Pondicherry",
                District = "Namakkal"
              }
        };

        [HttpGet]
        [Route("GetCollege")]
        public async Task<ActionResult<College>> GetCollege()
        {

            return Ok(Collegeouss);
        }

        [HttpGet]
        [Route("GetCollegeById")]
        public async Task<ActionResult<College>> GetCollege(int Id)

        {

            var college = Collegeouss.Find(val => val.Id == Id);
            if (college == null)
            {
                return BadRequest("COLLEGE STUDENTS ARE NOT FOUND");
            }
            else
            {
                return Ok(college);
            }
        }

        [HttpPost]
        [Route("Add_College")]
        public async Task<ActionResult<College>> AddCollege(College request)
        {
            Collegeouss.Add(request);
            return Ok(Collegeouss);
        }

        [HttpPost]

        [Route("Update College")]
        public async Task<ActionResult<College>> UpdateCollege(College request)
        {

            var college = Collegeouss.Find(val => val.Id == request.Id);
            if (college == null)
            {
                return BadRequest("Cannot able to Update the Employee");
            }
            else
            {
                college.Name = request.Name;
                college.Place = request.Place;
                college.District = request.District;
            }
            return Ok(Collegeouss);
        }

        [HttpDelete]

        [Route("delete College")]
        public async Task<ActionResult<College>> DeleteCollege(int Id)
        {
            var college = Collegeouss.Find(val => val.Id == Id);
            if (college == null)
            {
                return BadRequest("Record Not Deleted");
            }
            else
            {

                Collegeouss.Remove(college);
                return Ok(Collegeouss);
            }
        }
    }
}
