using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WickedlyHigh
{
    class MockAssetController : IAssetController
    {
        public List<AssetEntity> GetAssets()
        {
            var retval = new List<AssetEntity>()
            {
                new AssetEntity() {
                    ID = 1,
                    Name = @"Black and Decker Kettle"
                },
                new AssetEntity() {
                    ID = 2,
                    Name = @"Braun TextStyle Iron"
                }
            };
            return retval;
        }

        public AssetEntity GetAssetById(int ID)
        {
            return new AssetEntity()
            {
                ID = 1,
                Name = @"Black and Decker Kettle"
            };
        }

        protected void NotifyChange(string aChangedProperty)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(aChangedProperty));
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
    }
}
