using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.Core
{
    abstract class ModelBase
    {
        public string TableName;
        public List<string> Fields = new List<string>();
        public int MaxPosModelField { get; set; }
        public object[] FieldMap { get; set; }
        Type type;
        PropertyInfo[] pi;
        public ModelBase()
        {
            type = TransferType();
            TableName = type.Name;
            pi = type.GetProperties();
            FieldMap = new object[pi.Length];
            foreach(PropertyInfo p in pi)
            {
                Fields.Add(p.Name);
            }
        }
        protected abstract Type TransferType();
        public ModelBase Clone()
        {
            return (ModelBase)this.MemberwiseClone();
        }
        public void UpdateByModel(ModelBase m)
        {
            for (int i = 0; i < m.FieldMap.Length; i++)
            {
                if (m.FieldMap != null)
                {
                    FieldMap[i] = m.FieldMap[i];
                }
            }
        }

        protected void SetINT(int post, object value)
        {
            FieldMap[post] = value;
        }
        protected int GetINT(int post)
        {
            return FieldMap[post] != null ? int.Parse(FieldMap[post].ToString()) : 0;
        }

        protected void SetSTR(int post, object value)
        {
            FieldMap[post] = value;
        }
        protected string GetSTR(int post)
        {
            return FieldMap[post] != null ? FieldMap[post].ToString() : "";
        }
        protected void SetDT(int post, object value)
        {
            FieldMap[post] = value;
        }
        protected DateTime GetDT(int post)
        {
            return FieldMap[post] != null ? DateTime.Parse(FieldMap[post].ToString()) : new DateTime();
        }
        protected void SetD(int post, object value)
        {
            FieldMap[post] = value;
        }
        protected double GetD(int post)
        {
            return FieldMap[post] != null ? double.Parse(FieldMap[post].ToString()) : 0.0;
        }
    }
}
