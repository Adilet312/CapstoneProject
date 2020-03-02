/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */


/**
 *
 * @author Adilet
 */
public class Product {
    private Long id;
    private String productName;
    private String productDesc;
    private Double productPrice;
    public Product()
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
     * @return the productName
     */
    public String getProductName() {
        return productName;
    }

    /**
     * @param productName the productName to set
     */
    public void setProductName(String productName) {
        this.productName = productName;
    }

    /**
     * @return the productDesc
     */
    public String getProductDesc() {
        return productDesc;
    }

    /**
     * @param productDesc the productDesc to set
     */
    public void setProductDesc(String productDesc) {
        this.productDesc = productDesc;
    }

    /**
     * @return the productPrice
     */
    public Double getProductPrice() {
        return productPrice;
    }

    /**
     * @param productPrice the productPrice to set
     */
    public void setProductPrice(Double productPrice) {
        this.productPrice = productPrice;
    }
    /**
     * @return the string representation of product
     */
    public String toString()
    {
        String output = "Product{ "+
                        "  Id: " + this.id +
                        ", Name: "+this.productName + 
                        ", Description: " + this.productDesc + 
                        ", Price: " + this.productPrice +
                        "}";
        return output;
    }
    
    
}
