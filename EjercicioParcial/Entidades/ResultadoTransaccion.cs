using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [DataContract]
    public class ResultadoTransaccion
    {
        private bool _isOk;
        private string _error;
        private int _id;

        [DataMember]
        public bool IsOk
        {
            get
            {
                return this._isOk;
            }
            set
            {
                this._isOk = value;
            }
        }
        [DataMember]
        public string Error
        {
            get
            {
                return this._error;
            }
            set
            {
                this._error = value;
            }
        }
        [DataMember]
        public int Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }
    }
}
