"C:\Program Files (x86)\NUnit 2.6.4\bin\nunit-console.exe" /labels /out=TestResult.txt /xml=TestResult.xml /framework=net-4.0 F:\git\GoogleTest\GoogleTest\GoogleTest\bin\Debug\GoogleTest.dll
 
"F:\git\GoogleTest\GoogleTest\packages\SpecFlow.1.9.0\tools\SpecFlow.exe" nunitexecutionreport F:\git\GoogleTest\GoogleTest\GoogleTest\GoogleTest.csproj
 
IF NOT EXIST TestResult.xml GOTO FAIL
IF NOT EXIST TestResult.html GOTO FAIL
pause
 
:FAIL
echo ##teamcity[buildStatus status='FAILURE']
EXIT /B 1