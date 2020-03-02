/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */


/**
 *
 * @author Adilet
 */
public class Customer {
    private Long id;
    private String firstName;
    private String lastName;
    private String email;
    private String address;
    private String city;
    private String sate;
    private String zip;
    private String country;
    
    public Customer()
    {
        
    }

    /**
     * @return the id
     */
    public Long getId() {
        return id;
    }

    /**
     * @param id the id to set
     */
    public void setId(Long id) {
        this.id = id;
    }

    /**
     * @return the firstName
     */
    public String getFirstName() {
        return firstName;
    }

    /**
     * @param firstName the firstName to set
     */
    public void setFirstName(String firstName) {
        this.firstName = firstName;
    }

    /**
     * @return the lastName
     */
    public String getLastName() {
        return lastName;
    }

    /**
     * @param lastName the lastName to set
     */
    public void setLastName(String lastName) {
        this.lastName = lastName;
    }

    /**
     * @return the email
     */
    public String getEmail() {
        return email;
    }

    /**
     * @param email the email to set
     */
    public void setEmail(String email) {
        this.email = email;
    }

    /**
     * @return the address
     */
    public String getAddress() {
        return address;
    }

    /**
     * @param address the address to set
     */
    public void setAddress(String address) {
        this.address = address;
    }

    /**
     * @return the city
     */
    public String getCity() {
        return city;
    }

    /**
     * @param city the city to set
     */
    public void setCity(String city) {
        this.city = city;
    }

    /**
     * @return the sate
     */
    public String getSate() {
        return sate;
    }

    /**
     * @param sate the sate to set
     */
    public void setSate(String sate) {
        this.sate = sate;
    }

    /**
     * @return the zip
     */
    public String getZip() {
        return zip;
    }

    /**
     * @param zip the zip to set
     */
    public void setZip(String zip) {
        this.zip = zip;
    }

    /**
     * @return the country
     */
    public String getCountry() {
        return country;
    }

    /**
     * @param country the country to set
     */
    public void setCountry(String country) {
        this.country = country;
    }
    public String toString()
    {
        String output = "Customer { "+
                        ", Id: " + this.id +
                        ", First name: " + this.firstName + 
                        ", Last name: " + this.lastName +
                        ", Email: " + this.email + 
                        ", Address: " + this.address +
                        ", City: " + this.city + 
                        ", State: " + this.sate + 
                        ", Zip: " + this.zip +
                        ", Country: " + this.country +
                         " }";
        return output;
    }
    
    
}
