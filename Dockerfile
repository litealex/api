FROM mono:3.12

MAINTAINER  alexander zakharov "litealex@gmail.com"


ADD api/bin/Release /tmp/api

CMD mono /tmp/api/api.exe

EXPOSE 5000