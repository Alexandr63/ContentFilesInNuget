# ContentFilesInNuget
Test of unpack content files from nuget package.  
Fonts containts in 'LibA'. For building 'LibA' used '.nuspec' and '.props' files. 'LibB' use 'LibA' as nuget package. For building 'LibB' not used '.nuspec' and '.props' files. 'LibC' use 'LibA' as nuget package. For building 'LibC' not used '.nuspec' and '.props' files. Project 'Consumer' use 'LibCA' as nuget package and check fonts files in out directory.

# Steps
Create folder '\buildTransitive' in target project.  
Add fonts in folder '\buildTransitive\fonts\', set 'Build Action' = 'None', 'Copy to Output Directory' = 'Do not copy'.  
Create files:  
&nbsp;&nbsp;&nbsp;&nbsp;\buildTransitive\<project name>.nuspec  
&nbsp;&nbsp;&nbsp;&nbsp;\buildTransitive\<project name>.props  
Change project file:  
- Add references on '.props' and '.nuspec' files.  
- Add NuspecProperties with variables for nuspec file.  

**Note**: use '\\' instead of '/' in path https://github.com/microsoft/dotnet/issues/1208.  
