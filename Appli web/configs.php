<?php

$DB_SERVER = getenv("MVC_SERVER") ?: "192.168.10.15";
$DB_DATABASE = getenv("MVC_DB") ?: "goaty";
$DB_USER = getenv("MVC_USER") ?: "goaty-1";
$DB_PASSWORD = getenv("MVC_TOKEN") ?: "TasS9Gbs";
$DEBUG = getenv("MVC_DEBUG") ?: true;
$URL_VALIDATION = getenv("MVC_URL_VALIDATION") ?: "http://localhost:9000/valider-compte/";
$URL_VALIDATION_FORGET = getenv("MVC_URL_VALIDATION") ?: "http://localhost:9000/reset-password/";
$MAIL_SERVER = getenv("MVC_MAIL_SERVER") ?: "192.168.10.15";
$FROM_EMAIL = getenv("MVC_FROM_EMAIL") ?: "contact@localhost.fr";

return array(
    "DB_USER" => $DB_USER,
    "DB_PASSWORD" => $DB_PASSWORD,
    "DB_DSN" => "mysql:host=$DB_SERVER;dbname=$DB_DATABASE;charset=utf8",
    "DEBUG" => $DEBUG,
    "MAIL_SERVER" => $MAIL_SERVER,
    "FROM_EMAIL" => $FROM_EMAIL,
    "URL_VALIDATION" => $URL_VALIDATION,
    "URL_VALIDATION_FORGET" => $URL_VALIDATION_FORGET
);

