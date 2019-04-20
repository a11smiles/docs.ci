#!/bin/bash
token="$(cat sonar.txt)"
dir="$(pwd)"
dotnet sonarscanner begin /k:"a11smiles_docs.ci" /n:"docs.ci" /v:"1.0.0" /o:"a11smiles-github" /d:sonar.host.url="https://sonarcloud.io" /d:sonar.login="${token}" /d:sonar.language="cs" /d:sonar.exclusions="**/bin/**/*,**/obj/**/*" /d:sonar.coverage.exclusions="**/*Test.cs,**/Program.cs" /d:sonar.cs.opencover.reportsPaths="${dir}/.coverage/lcov.opencover.xml"
dotnet restore src/Docs/Docs.csproj
dotnet build src/Docs/Docs.csproj
dotnet restore test/Docs.Tests/Docs.Tests.csproj
dotnet test Project.Tests/Project.Tests.csproj /p:CollectCoverage=true /p:CoverletOutputFormat=\"opencover,lcov\" /p:CoverletOutput=../../.coverage/lcov /p:Include="[Docs]*"
dotnet sonarscanner end /d:sonar.login="${token}"