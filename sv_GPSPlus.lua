function gpsfunc(source, args, rawCommand)
	TriggerClientEvent("GPSPlus:Search", source, table.concat(args, " "))
end

RegisterCommand('gps', gpsfunc, false)
