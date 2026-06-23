import { currentUser } from "@clerk/nextjs/server"
import { redirect } from "next/navigation"
import ChatSidebar from "../../../modules/chat/components/chat-sidebar";
import Header from "../../../modules/chat/components/header";

const layout = async ({children}) => {
    const user = await currentUser()
    const email = user.primaryEmailAddress?.emailAddress;
    
    if (!user) redirect("/sign-in")
    
   return (<div className="flex h-screen overflow-hidden">
    <ChatSidebar userEmail={email} />
    <main className="flex-1 overflow-hidden">
    <Header/>
    {children}
    </main>
  </div>)
};


export default layout