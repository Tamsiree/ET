/* ========================================================
 * |
 * |     作者：Tamsiree
 * |     邮箱：
 * |     创建时间：2022年11月06日 星期日 17:58:16
 * |     文件：UnityConfigPartial
 * |     主要功能：
 * |     详细描述：
 * |     备注：
 * |     脚本版本：1.0
 * |     Unity版本：2020.3.32f1c1
 * |     [ Vision 1.0 ]
 * |
 *  ========================================================  */

using System.Collections.Generic;
using System.Numerics;

namespace ET
{
    public partial class UnitConfig
    {
        public Vector3 TestValue;
    }

    public class TestVector3
    {
        public Vector3 TestValue;
    }
    
    public partial class UnitConfigCategory
    {
        public List<TestVector3> TestVector3List = new List<TestVector3>();

        public override void AfterEndInit()
        {
            base.AfterEndInit();
            foreach (var config in this.dict.Values)
            {
                config.TestValue = new Vector3(config.Position, config.Height, config.Weight);
                this.TestVector3List.Add(new TestVector3() {TestValue = config.TestValue});
            }
        }

        public UnitConfig GetUnitConfigByHeight(int height)
        {
            UnitConfig config = null;
            foreach (var unitConfig in this.dict.Values)
            {
                if (unitConfig.Height == height)
                {
                    config = unitConfig;
                }
            }

            return config;
        }
    }
}