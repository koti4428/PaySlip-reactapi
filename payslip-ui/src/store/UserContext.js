import React, { useState, createContext, useEffect } from 'react';
import agent from '../api/agent';
export const UserContext = createContext();

export const UserProvider = (props) => {
  const [users, setUsers] = useState([]);
  const [stats, setStats] = useState([]);
  const [loading, setLoading] = useState(false);
  useEffect(() => {
    loadUsers();
    loadDesignationStats();
  }, []);
  const loadUsers = async () => {
    try {
      setLoading(true);
      const users = await agent.Users.list();
      console.log(users);
      setUsers(users);
      setLoading(false);
    } catch (error) {
      console.log(error);
    }
  };

  const loadDesignationStats = async () => {
    try {
      setLoading(true);
      const stats = await agent.Users.statList();
      console.log('stats', stats);
      setStats(stats);
      setLoading(false);
    } catch (error) {
      console.log(error);
    }
  };

  return (
    <UserContext.Provider
      value={[users, setUsers, loadUsers, loading, setLoading, stats, setStats]}
    >
      {props.children}
    </UserContext.Provider>
  );
};
