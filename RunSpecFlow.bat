GoogleTest\bin\Debug\nunit-console.exe /labels /out=TestResult.txt /xml=TestResult.xml /framework=net-4.0 GoogleTest\bin\Debug\GoogleTest.dll
 
packages\SpecFlow.1.9.0\tools\SpecFlow.exe nunitexecutionreport F:\git\GoogleTest\GoogleTest\GoogleTest\GoogleTest.csproj
 
IF NOT EXIST TestResult.xml GOTO FAIL
IF NOT EXIST TestResult.html GOTO FAIL
EXIT
 
:FAIL
echo ##teamcity[buildStatus status='FAILURE']
EXIT /B 1