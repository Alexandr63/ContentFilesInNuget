# ContentFilesInNuget
Test of unpack content files from nuget package.  
Fonts containts in 'LibA'. For building 'LibA' used '.nuspec' and '.props' files. 'LibB' use 'LibA' as nuget package. For building 'LibB' not used '.nuspec' and '.props' files. 'LibC' use 'LibA' as nuget package. For building 'LibC' not used '.nuspec' and '.props' files. Project 'Consumer' use 'LibCA' as nuget package and check fonts files in out directory.
