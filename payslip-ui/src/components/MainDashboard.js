import React from 'react';
import Navbar from './Navbar';
import Sidebar from './Sidebar';
import CreateEmployee from './CreateEmployee';
import { Switch, Route } from 'react-router-dom';
import ViewEmployees from './ViewEmployees';
import CreatePayslip from './CreatePayslip';
import ViewPayslips from './ViewPayslips';
import PayRecords from './PayRecords';
const MainDashboard = () => {
  return (
    <div className="container">
      <Sidebar />
      {/* <Navbar title="Dashboard" /> */}
      <div className="main-content">
        <Switch>
          <Route exact path="/" component={Navbar} />
          <Route exact path="/createemp" component={CreateEmployee} />
          <Route path="/viewemp" component={ViewEmployees} />
          <Route path="/createpay" component={CreatePayslip} />
          <Route path="/viewpay" component={ViewPayslips} />
          <Route path="/payrecord" component={PayRecords} />
        </Switch>
      </div>
    </div>
  );
};

export default MainDashboard;
