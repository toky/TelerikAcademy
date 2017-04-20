<?php

namespace App\Utilities;

class Bootstrap
{
    public function run()
    {
        $controller = $this->getController();
        $action = $this->getAction();

        $this->isCreatedInstance($controller, $action);
    }

    protected function getController()
    {
        $controller = "Web";
        
        if(php_sapi_name() == 'cli')
        {
            $controller = "Cli";
        }

        return $controller;
    }

    protected function getAction()
    {
        return 'index';
    }

    protected function getRout()
    {
        if (isset($_GET['url'])) {
            $params = array();
            $params = explode("/", $_GET['url']);
            $controller = ucwords($params[0]);
            
            if (isset($params[1]) && !empty($params[1])) {
                $action = ucwords($params[1]);
            }
            if (isset($params[2]) && !empty($params[2])) {
                $query = $params[2];
            } 
            
        }
    }

    protected function isCreatedInstance($controller, $action)
    {
        $class = new \ReflectionClass('App\Controllers\\'. $controller);
        if(!$class->hasMethod($action))
        {
            //To do error
        }
        
        $instance = $class->newInstance();

        call_user_func(array($instance, $action)); 
    }
   
}
