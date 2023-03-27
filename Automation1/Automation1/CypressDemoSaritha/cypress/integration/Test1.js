describe('My First Test Suite', () => {
    it('My First Test Case!', () =>{
        // test step
        cy.visit("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f")
        // Input username
        cy.get('#UserName').type('hari');
        // Input Password
        cy.get('#Password').type('123123');
        // click login button
        cy.get('.btn').click();
        //Assertion
        cy.get('[style="font-size:13px"] > :nth-child(1) > a').should('have.text','Dashboard')
    })
})

