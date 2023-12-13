using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using System.ComponentModel.DataAnnotations;

namespace RBC_oficial.Models;

public class CasoModel
{
    public int Id {get ; set; }
        [Required(ErrorMessage ="Preencha esse campo!")]

    public string? DescDoenca{get ; set;}
    public string? crophist {get ; set;}
    [Required(ErrorMessage ="Preencha esse campo!")]
    
   // public int? crophistnum{get; set;}
    public int? crophistnum => crophist switch
{
    "diff-1st-year" => 1,
    "same-1st-yr" => 2,
    "same-lst-two-yrs" =>3,
    "same-lst-sev-yrs"=>4,
    _ => null,
};

    
    public string? germination{get ; set;}
        [Required(ErrorMessage ="Preencha esse campo!")]

    //public int? germinationnum{get; set;}

public int? germinationnum => germination switch
{
    "lt-80%" => 1,
    "80-89%" => 2,
    "90-100%"=>4,
    _ => null,
};
    public string? seedtmt{get ; set;}
        [Required(ErrorMessage ="Preencha esse campo!")]

    //public int? seedtmtnum{get; set;}
public int? seedtmtnum => seedtmt switch
{
    "none" => 1,
    "fungicida" => 2,
    "Outros"=>3,
    _ => null,
};

    public string? date{get ; set;}
        [Required(ErrorMessage ="Preencha esse campo!")]

    //public int? datenum{get; set;}
public int? datenum => date switch
{
    "Janeiro" => 1,
    "Fevereiro" => 2,
    "Marco"=>3,
    "Abril"=>4,
    "Maio"=>5,
    "Junho"=>6,
    "Julho"=>7,
    "Agosto"=>8,
    "Setembro"=>9,
    "Outubro"=>10,
    "Novembro"=>11,
    "Dezembro"=>12,
    _ => null,
};

    public string? hail{get ; set;}
        [Required(ErrorMessage ="Preencha esse campo!")]

    //public int? hailnum{get; set;}

    public int? hailnum => hail switch
{
    "Yes" => 1,
    "No" => 2,
    _ => null,
};
    public string? areadamaged{get ; set;}
        [Required(ErrorMessage ="Preencha esse campo!")]

  //  public int? areadamagednum{get; set;}
public int? areadamagednum => areadamaged switch
{
    "low-areas" => 1,
    "scattered" => 2,
    "whole-field"=>3,
    "upper-areas"=>4,
    _ => null,
};
    public string? severity{get ; set;}
        [Required(ErrorMessage ="Preencha esse campo!")]

   // public int? severitynum{get; set;}

    public int? severitynum => severity switch
{
    "severe" => 1,
    "pot-severe" => 2,
    "Minor"=>3,
    _ => null,
};
    public string? temp{get ; set;}
        [Required(ErrorMessage ="Preencha esse campo!")]

    //public int? tempnum{get; set;}
    public int? tempnum => temp switch
{
    "norm" => 1,
    "gt-norm" => 2,
    "lt-norm"=>3,
    _ => null,
};
    public string? plantstand{get ; set;}
        [Required(ErrorMessage ="Preencha esse campo!")]

    //public int? plantstandnum{get; set;}
       public int? plantstandnum => plantstand switch
{
    "Normal" => 1,
    "lt-normal" => 2,
    _ => null,
};
    public string? leafspotshalo{get ; set;}
        [Required(ErrorMessage ="Preencha esse campo!")]

    //public int? leafspotshalonum{get; set;}
    public int? leafspotshalonum => leafspotshalo switch
{
    "Absent" => 1,
    "no-yellow-halos" => 2,
    "yellow-halos" => 3,
    _ => null,
};
    public string? lodging{get ; set;}
        [Required(ErrorMessage ="Preencha esse campo!")]

   // public int? lodgingnum{get; set;}
public int? lodgingnum => lodging switch
{
    "Yes" => 1,
    "No" => 2,
    _ => null,
};
    public string? precip{get ; set;}
        [Required(ErrorMessage ="Preencha esse campo!")]

    //public int? precipnum{get; set;}
   public int? precipnum => precip switch
{
    "Normal" => 1,
    "lt-normal" => 2,
    "GT-normal"=>3,
    _ => null,
};

    public string? stemcankers{get ; set;}
        [Required(ErrorMessage ="Preencha esse campo!")]

   // public int? stemcankersnum{get; set;}
public int? stemcankersnum => stemcankers switch
{
    "Above-sec-nde" => 1,
    "Above-soil" => 2,
    "below-soil"=>3,
    "Absent"=>4,
    _ => null,
};
    public string? seed{get ; set;}
        [Required(ErrorMessage ="Preencha esse campo!")]

    //public int? seednum{get; set;}
public int? seednum => seed switch
{
    "Norm" => 1,
    "Abnorm" => 2,
    _ => null,
};

    public string? seeddiscolor{get ; set;}
        [Required(ErrorMessage ="Preencha esse campo!")]

    //public int? seeddiscolornum{get; set;}
    public int? seeddiscolornum => seeddiscolor switch
{
    "Absent" => 1,
    "Present" => 2,
    _ => null,
};
    public string? leafspotsize{get ; set;}
        [Required(ErrorMessage ="Preencha esse campo!")]

    //public int? leafspotsizenum{get; set;}
    public int? leafspotsizenum => leafspotsize switch
{
    "dna" => 1,
    "gt-1/8" => 2,
    "lt-1/8" =>3,
    _ => null,
};
    public string? leafspotsmarg{get ; set;}
        [Required(ErrorMessage ="Preencha esse campo!")]

    //public int? leafspotsmargnum{get; set;}
      public int? leafspotsmargnum => leafspotsmarg switch
{
    "dna" => 1,
    "w-s-marg" => 2,
    "no-w-s-marg" =>3,
    _ => null,
};
    
    public string? cankerlesion{get ; set;}
        [Required(ErrorMessage ="Preencha esse campo!")]

    //public int? cankerlesionnum{get; set;}
        public int? cankerlesionnum => cankerlesion switch
{
    "Brown" => 3,
    "dna" => 1,
    "tan" =>2,
    "dk-brown-blk" =>4,
    _ => null,
};
   
    public string? externaldecay{get ; set;}
        [Required(ErrorMessage ="Preencha esse campo!")]

    //public int? externaldecaynum{get; set;}
    public int? externaldecaynum => externaldecay switch
{
    "firm-and-dry" => 1,
    "Absent" => 2,
    _ => null,
};
    public string? fruitspots{get ; set;}
        [Required(ErrorMessage ="Preencha esse campo!")]

    //public int? fruitspotsnum{get; set;}
    public int? fruitspotsnum => fruitspots switch
{
    "dna" => 1,
    "Absent" => 2,
    "Colored" =>3,
    "Brown-w/blk-specks" =>4,
    _ => null,
};
    public string? fruitingbodies{get ; set;}
        [Required(ErrorMessage ="Preencha esse campo!")]

    //public int? fruitingbodiesnum{get; set;}
    public int? fruitingbodiesnum => fruitingbodies switch
{
    "Present" => 1,
    "Absent" => 2,
    _ => null,
};
    public string? leafmalf{get ; set;}
        [Required(ErrorMessage ="Preencha esse campo!")]

    //public int? leafmalfnum{get; set;}
    public int? leafmalfnum => leafmalf switch
{
    "Present" => 2,
    "Absent" => 1,
    _ => null,
};
    public string? leafshread{get ; set;}
        [Required(ErrorMessage ="Preencha esse campo!")]

    //public int? leafshreadnum{get; set;}
    public int? leafshreadnum => leafshread switch
{
    "Present" => 2,
    "Absent" => 1,
    _ => null,
};
    public string? fruitpods{get ; set;}
        [Required(ErrorMessage ="Preencha esse campo!")]

   // public int? fruitpodsnum{get; set;}
    public int? fruitpodsnum => fruitpods switch
{
    "dna" => 1,
    "Norm" => 2,
    "Diseased"=> 3,
    "few-present"=> 4,
    _ => null,
};
    public string? intdiscolor{get ; set;}
        [Required(ErrorMessage ="Preencha esse campo!")]

   // public int? intdiscolornum{get; set;}
    public int? intdiscolornum => intdiscolor switch
{
    "None" => 1,
    "Black" => 2,
    "Brown"=> 3,
    _ => null,
};
    public string? leafmild{get ; set;} 
        [Required(ErrorMessage ="Preencha esse campo!")]

    //public int? leafmildnum {get; set;}
    public int? leafmildnum => leafmild switch
{
    "Absent" => 1,
    "Lower-surf" => 2,
    "Upper-surf"=> 3,
    _ => null,
};
    public string? leaves{get ; set;}
        [Required(ErrorMessage ="Preencha esse campo!")]

    //public int? leavesnum{get; set;}
public int? leavesnum => leaves switch
{
    "Abnorm" => 1,
    "Norm" => 2, 
    _ => null,
};
    public string? moldgrowth{get ; set;}
        [Required(ErrorMessage ="Preencha esse campo!")]

    //public int? moldgrowthnum{get; set;}
   public int? moldgrowthnum => moldgrowth switch
{
    "Absent" => 1,
    "Present" => 2, 
    _ => null,
};
    public string? mycelium{get ; set;}
        [Required(ErrorMessage ="Preencha esse campo!")]

    //public int? myceliumnum{get; set;}
    public int? myceliumnum => mycelium switch
{
    "Absent" => 1,
    "Present" => 2, 
    _ => null,
};
    public string? plantgrowth{get ; set;}
        [Required(ErrorMessage ="Preencha esse campo!")]

    //public int? plantgrowthnum{get; set;}
   public int? plantgrowthnum => plantgrowth switch
{
    "Abnorm" => 1,
    "Norm" => 2, 
    _ => null,
};
    public string? roots{get ; set;}
        [Required(ErrorMessage ="Preencha esse campo!")]

    //public int? rootsnum{get; set;}
    public int? rootsnum => roots switch
{
    "Norm" => 1,
    "Rotted" => 2, 
    "galls-cysts"=> 3,
    _ => null,
};
    public string? sclerotia{get ; set;}
        [Required(ErrorMessage ="Preencha esse campo!")]

    //public int? sclerotianum{get; set;}
   public int? sclerotianum => sclerotia switch
{
    "Absent" => 1,
    "Present" => 2, 
    _ => null,
};
    public string? seedsize{get ; set;}
        [Required(ErrorMessage ="Preencha esse campo!")]

    //public int? seedsizenum{get; set;}
    public int? seedsizenum => seedsize switch
{
    "Norm" => 1,
    "lt-norm" => 2, 
    _ => null,
};
    public string? shriveling{get ; set;}
        [Required(ErrorMessage ="Preencha esse campo!")]

    //public int? shrivelingnum{get; set;}
   public int? shrivelingnum => shriveling switch
{
    "Absent" => 1,
    "Present" => 2, 
    _ => null,
};
    public string? stem{get ; set;}
        [Required(ErrorMessage ="Preencha esse campo!")]

   // public int? stemnum{get; set;}
   public int? stemnum => stem switch
{
    "Abnorm" => 1,
    "Norm" => 2, 
    _ => null,
};
    

}