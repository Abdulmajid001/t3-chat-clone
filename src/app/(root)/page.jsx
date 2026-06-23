import Image from "next/image";
import ChatMessageView from "../../../modules/chat/components/chat-message-view";
import { currentUser } from "@clerk/nextjs/server";

export default async function Home() {
  const user = await currentUser()
  console.log("current",user.firstName)
  return (
    <div>
      <ChatMessageView firstName={user.firstName} />
    </div>
  );
}
