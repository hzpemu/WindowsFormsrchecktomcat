echo off 
echo ���� Tomcat ���� 
echo ================
echo ֹͣ Tomcat ����
echo ================
net stop "Tomcat6"
for /l %%a in (120,-1,0) do ping -n 2 127.1>nul&cls&echo %%a
echo ���� Tomcat ����
echo ================
net start "Tomcat6" 
pause