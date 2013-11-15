LunchAndLearn.Nancy
===================

Lunch and learn - Nancy lab

Install mono:
```
$ sudo apt-get install git autoconf automake libtool g++ gettext
$ mkdir ~/src
$ cd ~/src
$ git clone git://github.com/mono/mono.git
$ cd mono
$ ./autogen.sh --prefix=/usr/local
$ make get-monolite-latest
$ make
$ sudo make install
```

Install supervisor:
```
$ apt-get install supervisor
```

Create supervisor configuration /etc/supervisor/conf.d/lunchandlearnnancy.conf:
```
[program:nancydemo]
command=/usr/local/bin/mono Nancy.UI.Web.exe -d
user=www-data
stderr_logfile = /var/log/supervisor/lunchandlearnnancy-err.log
stdout_logfile = /var/log/supervisor/lunchandlearnnancy-stdout.log
directory=/pathtobuild/
```

Run supervisor:
```
$ sudo supervisorctl
$ supervisor>update
$ supervisor>start lunchandlearnnancy
```
