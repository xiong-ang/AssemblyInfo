# AssemblyInfo

## 用法   
1. 为了方便配置与管理，一个产品的所有Assemblies通常共用一个AssemblyInfo文件     
2. 通常做法是，创建一个存放AssemblyInfo的Solution Item，然后各个工程通过引用的方式Add这个文件   

## 获取信息   
1. 通常产品的About对话框需要获取AssemblyInfo里面的信息    
2. 代码片段：
```C#
Assembly _this = Assembly.GetExecutingAssembly();
FileVersionInfo version = FileVersionInfo.GetVersionInfo(_this.Location);
version.someProperity;
```   
