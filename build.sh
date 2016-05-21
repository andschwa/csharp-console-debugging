gcc -c -Wall -fpic libtest.c
gcc -shared -o libtest.so libtest.o
dotnet restore -v Warning
LD_LIBRARY_PATH+=$(pwd) dotnet test -xml results.xml -verbose -parallel none
