using UnityEngine;

namespace Flower
{
    /// <summary>
    /// 游戏入口
    /// </summary>
    public partial class GameEntry : MonoBehaviour
    {
        private void Start()
        {
            // 通过静态属性，引用组件方便全局访问
            InitBuiltinComponents();
            InitCustomComponents();
        }
    }
}
