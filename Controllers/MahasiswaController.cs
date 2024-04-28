using Microsoft.AspNetCore.Mvc;
using tpmodul10_1302220052;

namespace tpmodul10_1302223139.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> listMahasiswa = new List<Mahasiswa>
    {
        new Mahasiswa(" Nufal Ammar Zaidan", "1302220052"),
        new Mahasiswa(" Helmy Farikh", "1302220077"),
        new Mahasiswa(" Irham Baehaqi", "1302220063"),
        new Mahasiswa(" Muhammad Faqih Ainulyaqin", "1302220086")
    };
        [HttpGet]




        public IEnumerable<Mahasiswa> Get()
        {
            return listMahasiswa;
        }

        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return listMahasiswa[id];
        }

        [HttpPost]
        public void Post([FromBody] Mahasiswa mahasiswa)
        {
            listMahasiswa.Add(mahasiswa);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            listMahasiswa.RemoveAt(id);
        }
    }
}