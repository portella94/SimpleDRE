using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDRE
{
    class SubConta : Conta
    {
        public int idSubConta { get; set; }
        public string DescricaoSubConta { get; set; }

        public new static dynamic GetAll()
        {
            var db = Database.Connect();
            var col = db.GetCollection<SubConta>("subconta");
            return col.FindAll();
        }

        public static void Add(SubConta subconta)
        {
            var db = Database.Connect();
            var col = db.GetCollection<SubConta>("subconta");
            col.Insert(subconta);
        }
    }
}
