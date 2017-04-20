<?php
namespace App\Models;
/**
 * Class Grid - representation of the game grid
 *
 */
class Grid{
 	/**
    * @var int $row contain rows of grid
    * @var int $col contain columns of grid
    * @var array $ships contain game matrix
    */
	private $row, $col, $ships = [];

	public function __construct($row, $col, $ships)
	{
		$this->row = $row;
		$this->col = $col;
		foreach ($ships as $key => $ship) {
			$ship->getCoordinates();
		}
	}

	public function generateGrid()
	{
		echo "<pre>";
		for ($i=0; $i < 11; $i++) { 
			if($i > 0)
			{
				echo $i . "\040\040";
			}
			else{
				echo "\040\040";
			}
		}
		echo PHP_EOL;
		for ($row=0; $row < $this->row; $row++) { 
			echo chr($row+65) . "\040";
			for ($col=0; $col < $this->col; $col++) { 
					echo ". \040";
					//echo "[$row;$col]";
			}
			echo PHP_EOL;
		}
		echo "</pre>";
	}
}