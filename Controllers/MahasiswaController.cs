using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TP_Modul9.Models;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace TP_Modul9.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        // List static agar data tersimpan di memori (Persistence)
        private static List<Mahasiswa> _mahasiswaList = new List<Mahasiswa>
        {
            new Mahasiswa("Khalilur Rahman An Nafi", "103082400033"), 
            new Mahasiswa("Faris Rumakies", "1302000002"),
            new Mahasiswa("Muhammad Neymar", "1302000003")
        };

        // A. GET /api/Mahasiswa
        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return _mahasiswaList;
        }

        // B. POST /api/Mahasiswa
        [HttpPost]
        public void Post([FromBody] Mahasiswa mahasiswa)
        {
            _mahasiswaList.Add(mahasiswa);
        }

        // D. GET /api/Mahasiswa/{id}
        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return _mahasiswaList[id];
        }

        // E. DELETE /api/Mahasiswa/{id}
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _mahasiswaList.RemoveAt(id);
        }
    }
}
