using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxOfWishes.Models
{
    public interface IBOWItem
    {
        string GetTableName();
        int GetPrimaryKey();
    }
}
