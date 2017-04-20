<?php
namespace App\Controllers;
//use App\Controllers\Controller;
class Cli extends Controller
{
	
	public function index()
	{
		try {

			$grid = new \App\Models\Grid(10, 10, array());
			$grid->generateGrid();
			/*$view = new \App\Controllers\View(HOME . DS . 'Views' . DS . 'Web' . DS . 'index' . '.tpl');


			$view->set('name', 'meow');
			$view->setRender('Web', 'index');
			$viewTable = $view->render();
			$view->set('viewElement', $viewTable);
			$view->setFile('Web', 'index');

			return $view->autput();*/
		} catch (Exceptions $e) {
			echo "Application error:" . $e->getMessage();
		}
	}

}