<?php
namespace App\Models;

class Ship
{
	private $size, $startingCoordinate = [], $orientation, $coordinates = [];
	
	public function __construct($size, $startingCoordinate, $orientation)
	{
		$this->size = $size;
		$this->startingCoordinate = $startingCoordinate;
		$this->orientation = $orientation;

		$this->generateCoordinates();
	}

	public function getSize()
	{
		return $this->size;
	}

	public function getPosition()
	{
		return $this->getPosition;
	}

	protected function generateCoordinates()
	{	
		for ($i=0; $i < $this->size; $i++) { 
			
			if ($this->orientation == 1) 
			{
				$row = $this->startingCoordinate[0];
				$col = $this->startingCoordinate[1] + $i;
			}
			else{
				$row = $this->startingCoordinate[0] + $i;
				$col = $this->startingCoordinate[1];
			}

			$this->coordinates[] = $row . ';' . $col;
		}
	}

	public function getCoordinates()
	{
		echo "<pre>";
			var_dump($this->coordinates);
		echo "</pre>";
	}

}