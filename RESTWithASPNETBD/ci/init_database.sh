for i in `find /home/database/ -name "*.sql" | sort --version-sort`; do mysql -udocker -pdocker rest_asp_net < $i; done;

#list="$(find /home/database/ -name "*.sql" | sort --version-sort;)";
#for i in $list; do mysql -uroot -pdocker rest_asp_net < $i; done;