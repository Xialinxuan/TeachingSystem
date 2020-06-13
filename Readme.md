

## 一些可能会遇到的问题
### 端口问题
注意：这个仓库的端口是6600，不是5000

### 怎么配环境？
参考我上次写的：https://github.com/2020SP-ZJU-SE-LYS-T1/DevelopmentContainer 的ReadMe

### 默认用户？
用户名密码都是 admin
### 现在有哪些支持的操作？
可以访问`/BasicInfo/Manage/Account` 添加删除用户，可以访问`/BasicInfo/Manage/Course`添加删除课程

### 怎么组织代码结构？
每个组都在`Areas`下面自己的文件夹里工作，一般你会需要`Page` `Data` `Shared`三个子文件夹，分别存页面、数据、组件。

### 如何初始化数据库？

```bash
dotnet ef database update
```
### 我修改了数据库里的东西以后要做什么？
首先添加Migration
```bash
dotnet ef migrations add SomeName
```

然后按照上一条重新update

### 怎么操作数据库？
采用Entity Framework Core
参考：https://docs.microsoft.com/en-us/ef/core/

用的时候需要依赖注入`TSSDbContext DbContext`，组件里面我已经在`_Imports.razor`里面注入好了，可以直接用`DbContext`

### 怎么针对用户身份进行限制？

参考：https://docs.microsoft.com/en-us/aspnet/core/security/blazor/?view=aspnetcore-3.1

例如：
1. 整页，必须是某种身份才可以访问 `@attribute [Authorize(Roles = "Admin")]` 参考 `Areas/BasicInfo/Pages/Manage/Account/Index.razor`
2. 不同身份显示不同的内容 参考 `Shared/LoginDisplay.razor`

### 我不小心把admin账号取消了Admin身份怎么办？
去 `/Areas/BasicInfo/Pages/Manage/Account` 把里面每页的身份限制暂时删了，这样就可以访问了

### 为什么`DbContext`里面没有Users？

需要依赖注入 `UserManager<User> _userManager`，然后`_userManager.Users` 

### UI怎么搞？

本质就是html。
参考Material Blazor的文档：https://www.matblazor.com/

### 怎么跳转？
用`NavigationManager.NavigateTo("xxx")`

