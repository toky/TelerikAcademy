<?php
namespace App\Controllers;

class Web extends Controller
{ 
	public function index()
	{
		try {

			$battleShip = new \App\Models\Battleship(array(1,5), 0);
			$firstDestroyer = new \App\Models\Destroyer(array(3,1), 0);
			$secondDestroyer = new \App\Models\Destroyer(array(4,6), 0);

			$grid = new \App\Models\Grid(10, 10, array($battleShip, $firstDestroyer, $secondDestroyer));
			$grid->generateGrid();

			
			
			//$ship->generateCoordinates();


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