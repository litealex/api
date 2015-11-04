cd /tmp
git clone https://github.com/litealex/api.git
cd api
nuget restore
xbuild
mono /tmp/api/api/bin/Debug/api.exe