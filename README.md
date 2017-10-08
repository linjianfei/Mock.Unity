# Mock.Unity
Mock UnityEngine For Test

1. 生成冒牌 UnityEngine.Dll 和 UnityEngine.UI.Dll,可以在纯VS环境下运行。
2. 反编译UnityEngine，删除了大部分全部对底层C++库的引用。
3. 重写了 GameObject和 Transform，可以应对大部分测试需求。

## 使用场景
Mock View层

## Todo
- GameObject生命周期管理
- Update驱动
- 协程
- PlayerPref
