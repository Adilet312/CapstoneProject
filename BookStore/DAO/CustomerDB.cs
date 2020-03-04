package book.data;

import java.sql.*;

import book.business.Customer;

public class CustomerDB {

    public static int insert(Customer customer) {
        ConnectionPool pool = ConnectionPool.getInstance();
        Connection connection = pool.getConnection();
        PreparedStatement ps = null;

        String query
                = "INSERT INTO Customer (FirstName, LastName,Email,Address,City,State,Zip,Country) "
                + "VALUES (?, ?, ?, ?, ?, ?, ?, ?)";
        try {
            ps = connection.prepareStatement(query);
            ps.setString(1, customer.getFirstName());
            ps.setString(2, customer.getLastName());
            ps.setString(3, customer.getEmail());
            ps.setString(4, customer.getAddress());
            ps.setString(5, customer.getCity());
            ps.setString(6, customer.getState());
            ps.setString(7, customer.getZip());
            ps.setString(8, customer.getCountry());
            return ps.executeUpdate();
        } catch (SQLException e) {
            System.out.println(e);
            return 0;
        } finally {
            DBUtil.closePreparedStatement(ps);
            pool.freeConnection(connection);
        }
    }

    public static int update(Customer customer) {
        ConnectionPool pool = ConnectionPool.getInstance();
        Connection connection = pool.getConnection();
        PreparedStatement ps = null;

        String query = "UPDATE Customer SET "
                + "FirstName = ?, "
                + "LastName = ?, "
                + "Address = ?, "
                + "City = ?, "
                + "State = ?, "
                + "Zip = ?, "
                + "Country = ? "
                + "Where Email = ? ";
        try {
            ps = connection.prepareStatement(query);
            ps.setString(1, customer.getFirstName());
            ps.setString(2, customer.getLastName());
            ps.setString(3, customer.getEmail());
            ps.setString(4, customer.getAddress());
            ps.setString(5, customer.getCity());
            ps.setString(6, customer.getState());
            ps.setString(7, customer.getZip());
            ps.setString(8, customer.getCountry());

            return ps.executeUpdate();
        } catch (SQLException e) {
            System.out.println(e);
            return 0;
        } finally {
            DBUtil.closePreparedStatement(ps);
            pool.freeConnection(connection);
        }
    }

    public static int delete(Customer customer) {
        ConnectionPool pool = ConnectionPool.getInstance();
        Connection connection = pool.getConnection();
        PreparedStatement ps = null;

        String query = "DELETE FROM Customer "
                + "WHERE Email = ?";
        try {
            ps = connection.prepareStatement(query);
            ps.setString(3, customer.getEmail());

            return ps.executeUpdate();
        } catch (SQLException e) {
            System.out.println(e);
            return 0;
        } finally {
            DBUtil.closePreparedStatement(ps);
            pool.freeConnection(connection);
        }
    }

    public static boolean emailExists(String email) {
        ConnectionPool pool = ConnectionPool.getInstance();
        Connection connection = pool.getConnection();
        PreparedStatement ps = null;
        ResultSet rs = null;

        String query = "SELECT Email FROM Customer "
                + "WHERE Email = ?";
        try {
            ps = connection.prepareStatement(query);
            ps.setString(3, email);
            rs = ps.executeQuery();
            return rs.next();
        } catch (SQLException e) {
            System.out.println(e);
            return false;
        } finally {
            DBUtil.closeResultSet(rs);
            DBUtil.closePreparedStatement(ps);
            pool.freeConnection(connection);
        }
    }

    public static Customer selectCustomer(String email) {
        ConnectionPool pool = ConnectionPool.getInstance();
        Connection connection = pool.getConnection();
        PreparedStatement ps = null;
        ResultSet rs = null;

        String query = "SELECT * FROM Customer "
                + "WHERE Email = ?";
        try {
            ps = connection.prepareStatement(query);
            ps.setString(3, email);
            rs = ps.executeQuery();
            Customer customer = null;
            if (rs.next()) {
                customer = new Customer();
                customer.setFirstName(rs.getString("FirstName"));
                customer.setLastName(rs.getString("LastName"));
                customer.setEmail(rs.getString("Email"));
                customer.setAddress(rs.getString("Address"));
                customer.setCity(rs.getString("City"));
                customer.setState(rs.getString("State"));
                customer.setZip(rs.getString("Zip"));
                customer.setCountry(rs.getString("Country"));
            }
            return customer;
        } catch (SQLException e) {
            System.out.println(e);
            return null;
        } finally {
            DBUtil.closeResultSet(rs);
            DBUtil.closePreparedStatement(ps);
            pool.freeConnection(connection);
        }
    }
}