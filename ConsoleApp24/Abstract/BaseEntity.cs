using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboAzProject.Model.Abstract
{
    public abstract class BaseEntity
    {
        public DateTime CreatedDate = DateTime.Now;
        public DateTime? ModifiredDate = DateTime.Now;
    }
}
