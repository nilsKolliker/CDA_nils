<?php

class Plan_Interruptions 
{

	/*****************Attributs***************** */

	private $_idInterruption;
	private $_dateDebut;
	private $_dateFin;
	private $_idAction;
	private static $_attributes=["idInterruption","dateDebut","dateFin","idAction"];
	/***************** Accesseurs ***************** */


	public function getIdInterruption()
	{
		return $this->_idInterruption;
	}

	public function setIdInterruption(?int $idInterruption)
	{
		$this->_idInterruption=$idInterruption;
	}

	public function getDateDebut()
	{
		return is_null($this->_dateDebut)?null:$this->_dateDebut->format('Y-n-j');
	}

	public function setDateDebut(string $dateDebut)
	{
		$this->_dateDebut=DateTime::createFromFormat("Y-n-j",$dateDebut);
	}

	public function getDateFin()
	{
		return is_null($this->_dateFin)?null:$this->_dateFin->format('Y-n-j');
	}

	public function setDateFin(string $dateFin)
	{
		$this->_dateFin=DateTime::createFromFormat("Y-n-j",$dateFin);
	}

	public function getIdAction()
	{
		return $this->_idAction;
	}

	public function setIdAction(?int $idAction)
	{
		$this->_idAction=$idAction;
	}

	public static function getAttributes()
	{
		return self::$_attributes;
	}

	/*****************Constructeur***************** */

	public function __construct(array $options = [])
	{
 		if (!empty($options)) // empty : renvoi vrai si le tableau est vide
		{
			$this->hydrate($options);
		}
	}
	public function hydrate($data)
	{
 		foreach ($data as $key => $value)
		{
 			$methode = "set".ucfirst($key); //ucfirst met la 1ere lettre en majuscule
			if (is_callable(([$this, $methode]))) // is_callable verifie que la methode existe
			{
				$this->$methode($value===""?null:$value);
			}
		}
	}

	/*****************Autres Méthodes***************** */

	/**
	* Transforme l'objet en chaine de caractères
	*
	* @return String
	*/
	public function toString()
	{
		return "IdInterruption : ".$this->getIdInterruption()."DateDebut : ".$this->getDateDebut()."DateFin : ".$this->getDateFin()."IdAction : ".$this->getIdAction()."\n";
	}
}