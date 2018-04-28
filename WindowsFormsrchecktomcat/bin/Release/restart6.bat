echo off 
echo 重启 Tomcat 服务 
echo ================
echo 停止 Tomcat 服务
echo ================
net stop "Tomcat6"
for /l %%a in (120,-1,0) do ping -n 2 127.1>nul&cls&echo %%a
echo 启动 Tomcat 服务
echo ================
net start "Tomcat6" 
pause