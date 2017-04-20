<?php
namespace App\Controllers;

class View
{
	protected $_file;
	protected $_date = array();
	public $_renderFile;

	public function __construct($file){
		$this->_file = $file;
	}
	
	public function set($key, $value){
		$this->_date[$key] = $value;
	}
	
	public function get(){
		return $thus->_date[$key];
	}

	public function setRender($setRenderFolder,$setRenderFile){
		$this->_renderFile = HOME . DS . 'src\Views' . DS . $setRenderFolder . DS . $setRenderFile . '.tpl';
	}

	public function render(){
		if(!file_exists($this->_renderFile)){
			throw new \App\Controller\Exceptions("Темплейтът 2 който се опитвате да заредите не съществува.");
		}
		extract($this->_date);
		ob_start();
		include($this->_renderFile);
		$renderOutput = ob_get_contents();
		ob_end_clean();
		return $renderOutput;
	}
	
	public function setFile($setFolder,$setFile){
		$this->_file = HOME . DS . 'src\Views' . DS . $setFolder . DS . $setFile . '.tpl';
	}
	
	public function autput(){
		
		if(!file_exists($this->_file)){
			throw new Exceptions("Темплейтът който се опитвате да заредите не съществува.");
		}
		
		extract($this->_date);
		
		ob_start();
		include($this->_file);
		$output = ob_get_contents();
		ob_end_clean();
		echo $output;
	}
	
	
}