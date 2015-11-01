FROM mono:3.12

MAINTAINER  alexander zakharov "litealex@gmail.com"


ADD start.sh /tmp/
RUN chmod +x /tmp/start.sh

# curl mono git
RUN apt-get update \
	&& apt-get install -y git 



EXPOSE 5000

CMD ./tmp/start.sh








