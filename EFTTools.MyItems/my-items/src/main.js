"use strict"

const foo = () => {
    const postDBLoad = (container) => {
        const config = require("./config.json")
        replaceItems(config, container)
    }

    const replaceItems = (config, container) => {
        const items = container.resolve("DatabaseServer").getTables().templates.items;
        const locations = container.resolve("DatabaseServer").getTables().locations;

        for (const conf in config) {
            const eftMap = locations[conf];
            if (eftMap === undefined) {
                console.error(`地图:${conf}未找到,跳过导入自定义物品刷新`)
                continue;
            }

            const spawnpoints = eftMap.looseLoot.spawnpoints;
            for (const sp of spawnpoints) {
                sp["probability"] = 1
                sp["IsAlwaysSpawn"] = true
                for (const item of sp.itemDistribution) {
                    const configItem = config[conf][item.tpl]
                    if (configItem === undefined) {
                        continue
                    }
                    item.tpl = configItem.tpl
                    item.relativeProbability = configItem.probably
                }
            }
        }
    }
    return { postDBLoad }
}

module.exports = { mod: foo() };