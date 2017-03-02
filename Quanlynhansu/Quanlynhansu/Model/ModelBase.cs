using System;
using System.Reflection;

namespace Quanlynhansu.Model
{
    abstract class ModelBase
    {
        public string ModelName;
        public string[] FieldsName;
        public object[] FieldsValue;
        Type TObj;
        public void Initialize()
        {
            TObj = this.GetType();
            ModelName = TObj.Name;
            PropertyInfo[] pi = TObj.GetProperties();
            int pos = 0;
            FieldsName = new string[pi.Length];
            FieldsValue = new object[pi.Length];
            foreach(PropertyInfo p in pi)
            {
                FieldsName[pos] = p.Name;
                pos++;
            }
        }
        public void SetVal(int pos,object val)
        {
            FieldsValue[pos] = val;
        }
        public int GetINT(int pos)
        {
            return int.Parse(FieldsValue[pos].ToString());
        }
        public string GetSTR(int pos)
        {
            return FieldsValue[pos].ToString();
        }
        public DateTime GetDT(int pos)
        {
            return DateTime.Parse(FieldsValue[pos].ToString());
        }
    }
}
