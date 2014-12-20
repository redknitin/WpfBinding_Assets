using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WickedlyHigh
{
    public interface IAssetController : INotifyPropertyChanged
    {
        List<AssetEntity> GetAssets();
        AssetEntity GetAssetById(int ID);
    }
}
