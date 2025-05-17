using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using tpmodul9_2311104065.Models;

namespace tpmod9_2311104042.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MahasiswaController : ControllerBase
    {

        private static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>
 {
 new Mahasiswa { Nama = "rengganis", Nim = "2311104065" },
 new Mahasiswa { Nama = "suga", Nim = "2311104001" },
 new Mahasiswa { Nama = "jimin", Nim = "2311104076" }
 };

        [HttpGet]
        public ActionResult<List<Mahasiswa>> Get()
        {
            return daftarMahasiswa;
        }
        [HttpGet("{index}")]
        public ActionResult<Mahasiswa> Get(int index)
        {
            if (index < 0 || index >= daftarMahasiswa.Count)
                return NotFound();
            return daftarMahasiswa[index];
        }

        [HttpPost]
        public ActionResult<List<Mahasiswa>> Post([FromBody] Mahasiswa mhs)
        {
            daftarMahasiswa.Add(mhs);
            return daftarMahasiswa;
        }
        [HttpDelete("{index}")]
        public ActionResult<List<Mahasiswa>> Delete(int index)
        {
            if (index < 0 || index >= daftarMahasiswa.Count)
                return NotFound();
            daftarMahasiswa.RemoveAt(index);
            return daftarMahasiswa;
        }
    }
}