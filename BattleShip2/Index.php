<?php
error_reporting(E_ALL);
ini_set('display_errors', 1);

require_once("/vendor/autoload.php");
require_once("config.php");

$application = new App\Utilities\Bootstrap();
$application->run();

