import { Given, When, Then } from "cypress-cucumber-preprocessor/steps";

Given('I have navigated to the turnup portal page', () => {
    cy.visit("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f")   
})

When('I input username', () =>{
    cy.get('#UserName').type('hari'); 
})

When('I input password', () =>{
    cy.get('#Password').type('123123'); 
})

Then('I should see the homepage displayed', () =>{
    cy.get('.btn').click();
    cy.get('[style="font-size:13px"] > :nth-child(1) > a').should('have.text','Dashboard')
})