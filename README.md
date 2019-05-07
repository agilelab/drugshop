一、AgileEAS.NET SOA中间件应用开发简介
--------
在4月份，callhot写过一系列的有关于AgileEAS.NET平台的开发应用的系列AgileEAS.NET平台开发Step By Step系列-药店系统-索引，他通过一个接近于实际应用的案例，从头到尾的向大家展示了AgileEAS.NET平台在企业信息系统开发中的应用及其应用开发的过程。

AgileEAS.NET平台是一套应用系统快速开发平台，用于帮助中小软件开发商快速构建自己的企业信息管理类开发团队，以达到节省开发成本、缩短开发时间，快速适应市场变化的目的，AgileEAS.NET应用开发平台包含基础类库、资源管理平台、运行容器、开发辅助工具等四大部分，资源管理平台为敏捷并行开发提供了设计、实现、测试等开发过程的并行。

AgileEAS.NET平台基于软件过程改进以及构件化快速开发两方面达到这方面的目标，在软件过程改进实践方面，提出了独有的“敏捷并行开发方法”开发方法，其目的是在软件的管理之中提出符合国内中小软件企业实际情况并且可操作的软件工程实践、软件过程改进思想、及相配套的项目管理系统。

在快速开发方面，AgileEAS.NET平台平台提供了企业应用开发所需的诸如ORM、IOC、分布式通信、插件与平台基础结构以及一系统的快速生成工具，涵盖开发过程中的设计、编码、集成、部署、运维等各个环节。

![github](https://github.com/agilelab/drugshop/blob/master/Documents/drugshop1.png "drugshop")  

在callhot的AgileEAS.NET平台开发Step By Step系列-药店系统的系统之中，他详细的向大家展示了AgileEAS.NET平台在企业信息系统中提供的强大支持，在短短的一个月时间之向，向大家贡献了一个完整的案例及配套的几十篇渐进式教程，我相信大家通过他的教程，都能应用AgileEAS.NET平台中小型企业应用。

二、药店系统的SAAS部署
--------
Callhot接手了新的工作，我在他留下的代码的基础之上，采用了最新的AgileEAS.NET平台进行了一个重构和裁剪，并且通过互联网以SAAS结构向大家发布了这个应用，其总体结构如下。

![github](https://github.com/agilelab/drugshop/blob/master/Documents/drugshop2.png "drugshop")  

数据库和分布式应用层我部署在我的互联网服务器上，客户端我将提供一个msi包给大家下载，客户端和应用服务器可以通过webservice、WCF(http/TCP)进行数据通信，最终运行界面如下：

![github](https://github.com/agilelab/drugshop/blob/master/Documents/drugshop3.png "drugshop")  

三、客户端下载及使用说明
--------
客户软编译版本我打开了rar压缩包，请大家通过这里下载,下载解压缩后运行EAS.WinClient.exe文件。

大家可以使用0001(采购员)，0002(销售员)，0003(店长)三个账号登录药店系统，所有密码均为空，三个账户操作权限不同，请大家不要修改密码。

在下载包中的EAS.Winclient.exe.config文件之中记录应用程序服务器的通信设置。

    <services>
            <service name="RMIService" service-type="WebService" singleton="true" url="http://www.agilelab.cn/xservice/rmiservice.asmx" />
            <!--<service name="RMIService" service-type="WcfService" singleton="true" url="net.tcp://202.100.84.179:6688/EAS.RMIService" />-->
        </services>
系统默认使用WebService通信，连接至http://www.agilelab.cn/xservice/rmiservice.asmx，我在http://www.agileleab.cn/网站以iis宿住部署了webservice方式部署了通信服务，业务层寄宿在iis之中运行。

使用者也可以替换为wcf/tcp通信，连接至net.tcp://202.100.84.179:6688/EAS.RMIService，我在202.100.84.179部署了一套独立的基于wcf/tcp通信的应用服务程序。

友情提示一下，webservice通信较慢，特别是在登录界面之上，点了登录可能要等一会，因为使用的是SericeLocator动态调用技术，涉及编译webservice的代理类,请大家理解。

四、关于自动升级
--------
在AgileEAS.NET平台本次重构过程之中，废弃了原有的基于插件的静默升级形式，替换了比较通过的独立升级程序，升级参数通过客户端目录中的update.ini文件升级。

    #AgileEAS.Net 平台升级控制文件
    [config]
 
    allow = 1
    url = http://www.agilelab.cn/xservice/smartupdateservice.asmx
    #url = net.tcp://202.100.84.179:6688/EAS.SmartUpdateService
 
升级技术同样也可以采用ws技术也可采用wcf技术，目前，为了避免多点升级维护的麻烦，只提供于ws的升级，升级服务地址
