import React from "react";
import {NavLink} from "react-router-dom";
import Card from 'react-bootstrap/Card';
import Row from 'react-bootstrap/Row';
import Col from 'react-bootstrap/Col';

export function MealWrapper({id, title,imageUrl,maxReservations}){
 
     return (
       <>
{/*      
      <Card>
  <Card.Img variant="top" src={imageUrl} style= {{ height: '100px', width: '200px' , padding:'20px', margin: '20px', justifyContent:'center'}}/>
  <Card.Body>
  <NavLink to= {"/meal/"+ id}>
    <Card.Title>{title}</Card.Title>
    <Card.Text>
    Maximum reservations: {maxReservations}
    </Card.Text>
    </NavLink>
  </Card.Body>
  </Card> */}
   
  <div className="title">
         
           <img className="images" src={imageUrl}></img>
       
           <NavLink to={"/meal/" + id}>
             <h1> {title}</h1>

             <h4>Maximum reservations: {maxReservations}</h4>
           </NavLink>
         </div>
       </>
     ); 

} 