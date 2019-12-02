using LiteDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDRE
{
    public class Conta
    {
        [BsonId]
        public int idConta { get; set; }
        public string DescricaoConta { get; set; }

        public TipoConta TipoConta { get; set; }

        public string DescricaoTipoConta()
        {
            DescriptionAttribute[] attributes = (DescriptionAttribute[])TipoConta
               .GetType()
               .GetField(TipoConta.ToString())
               .GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : string.Empty;
        }

        public static int GetId()
        {
            var db = Database.Connect();
            var id = LiteDB.ObjectId.NewObjectId();
            return Convert.ToInt32(id);
        }

        public static dynamic GetAll()
        {
            var db = Database.Connect();
            var col = db.GetCollection<Conta>("conta");
            return col.FindAll();
        }

        public static void Insert(Conta conta)
        {
            var db = Database.Connect();
            var col = db.GetCollection<Conta>("conta");
            col.Insert(conta);
        }


    }

    public enum TipoConta
    {
        [Description("Ativo")]
        Ativo = 1,
        [Description("Passivo")]
        Passivo = 2,
        [Description("Despesas")]
        Despesas = 3,
        [Description("Receitas")]
        Receitas = 4,
    }
}
