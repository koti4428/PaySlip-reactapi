import React, { useState } from 'react';
import { IoIosCreate, IoIosList } from 'react-icons/io';
import { HiOutlineClipboardList } from 'react-icons/hi';
import { MdAttachMoney } from 'react-icons/md';
import { AiOutlineFolderView } from 'react-icons/ai';
import AppOptions from '../common/AppOptions';
import { NavLink } from 'react-router-dom';
const Sidebar = () => {
  const [linkName, setLinkName] = useState('Dashboard');

  return (
    <div className="sidebar ">
      <div className="date-info text-align">{new Date().toDateString()}</div>
      <div className="app-options">
        <NavLink to={'/createemp'}>
          <AppOptions text="Create Employee" Icon={<IoIosCreate />} />
        </NavLink>
        <NavLink to={'/viewemp'}>
          <AppOptions text="View Employee" Icon={<IoIosList />} />
        </NavLink>
        <NavLink to={'/createpay'}>
          <AppOptions text="Generate Payslip" Icon={<MdAttachMoney />} />
        </NavLink>
        <NavLink to={'/viewpay'}>
          <AppOptions text="View Payslip" Icon={<AiOutlineFolderView />} />
        </NavLink>
        <NavLink to={'/payrecord'}>
          <AppOptions text="Pay Records" Icon={<HiOutlineClipboardList />} />
        </NavLink>
      </div>
    </div>
  );
};

export default Sidebar;
