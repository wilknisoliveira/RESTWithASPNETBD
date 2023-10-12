FROM mysql:5.7.22
EXPOSE 3306
COPY ./RESTWithASPNETBD/db/migrations/ /home/database/
COPY ./RESTWithASPNETBD/db/dataset/ /home/database/
COPY ./RESTWithASPNETBD/ci/init_database.sh/ /docker-entrypoint-initdb.d/init_database.sh