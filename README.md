


ShadowsocksR for Windows with login by AAA
=======================
感谢匿名大佬，此项目所有工作均由匿名大佬完成，我只是个上传的

特性：填写网址/api/login、用户名和密码既可以获取节点
例如：
 - 网址:http://example/api/login
 - 用户名:user
 - 密码:passwd

客户端：https://github.com/dumplin233/shadowsocks-csharp/releases

面板：https://github.com/NimaQu/ss-panel-v3-mod_Uim/commits/ShadowsocksR-for-Windows-with-login-support

爬虫模式介绍:只要用户中心有ssr://批量链接即可获取节点，无需更新面板（Uim版目前暂不支持，支持魔改版、魔改91vps版）
例如：
 - 网址:http://example/ （注意：最后必须要有'/'）
 - 用户名:user
 - 密码:passwd

[![Build Status]][Appveyor]

#### Download

You will need to download and install [7-Zip](http://www.7-zip.org/) in order 
to extract the ShadowsocksR archive.

Download the [latest release] for ShadowsocksR for Windows.

_Optionally_, right-click on the downloaded 7z file and select 
**CRC SHA** > **SHA-256**. Verify that the SHA-256 checksum displayed 
matches the expected checksum which was shown on the releases page.

Right-click on the downloaded 7z file and do **7-Zip** > **Extract Here** 
or extract to a new folder.

_Optionally_, download and install [Gpg4win](https://www.gpg4win.org/). 
From the Windows start menu, launch program **Kleopatra**. 
Do **File** > **New Certificate** to create a personal OpenPGP key pair. 
Save the signing key from
[breakwa11/pubkey](https://github.com/breakwa11/pubkey) as a text file. 
Then do **File** > **Import Certificates** to import the signing key text file.
After import, select the signing key and do 
**Certificates** > **Certify Certificates**. 
You will need to enter the passphrase for your own key. 
Finally, do **File** > **Decrypt/Verify Files** for the executable 
you propose to use (see below). A message confirming successful verification 
of the signature appears against a green background. 
Close program **Kleopatra**.

For >= Windows 8 or with .Net 4.0, using ShadowsocksR-dotnet4.0.exe.

For <= Windows 7 or with .Net 2.0, using ShadowsocksR-dotnet2.0.exe.

#### Usage

1. Find ShadowsocksR icon in the notification tray
2. You can add multiple servers in servers menu
3. Select Enable System Proxy menu to enable system proxy. Please disable other
proxy addons in your browser, or set them to use system proxy
4. You can also configure your browser proxy manually if you don't want to enable
system proxy. Set Socks5 or HTTP proxy to 127.0.0.1:1080. You can change this
port in Global settings
5. You can change PAC rules by editing the PAC file. When you save the PAC file
with any editor, ShadowsocksR will notify browsers about the change automatically
6. You can also update the PAC file from GFWList. Note your modifications to the PAC
file will be lost. However you can put your rules in the user rule file for GFWList.
Don't forget to update from GFWList again after you've edited the user rule
7. For UDP, you need to use SocksCap or ProxyCap to force programs you want
to proxy to tunnel over ShadowsocksR

### Develop

Visual Studio Express 2012 is recommended.

#### License

GPLv3

Copyright © BreakWa11 2017. Fork from Shadowsocks by clowwindy

[Appveyor]:       https://ci.appveyor.com/project/breakwa11/shadowsocksr-csharp
[Build Status]:   https://ci.appveyor.com/api/projects/status/itcxnad1y95gf2x5/branch/master?svg=true
[latest release]: https://github.com/shadowsocksr/shadowsocksr-csharp/releases
